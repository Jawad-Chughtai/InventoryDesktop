using BarcodeLib;
using InventoryDesktop.Applications.PurchaseItems;
using InventoryDesktop.EntityFramework.PurchaseItems;
using InventoryDesktop.EntityFramework.Purchases;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Imaging;

namespace InventoryDesktop.Applications.Purchases
{
    public class PurchaseService
    {
        private readonly PurchaseRepository _purchaseRepository = new();
        private readonly PurchaseItemRepository _purchaseItemRepository = new();

        public async Task CreateAsync(Purchase purchase)
        {
            if (purchase == null) throw new ArgumentNullException(nameof(purchase));

            purchase.Batch = purchase.Batch.Trim().ToUpper();
            purchase.Barcode = await GenerateBarcode();
            var item = await _purchaseItemRepository.GetAsync(purchase.PurchaseItemId);
            purchase.PurchaseItemDescription = item.Code + ' ' + item.Name;
            await _purchaseRepository.CreateAsync(purchase);
        }

        public async Task<List<Purchase>> GetListAsync(string? filter = null, int? purchaseItemId = null)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                filter = null;
            }
            if (purchaseItemId < 1)
            {
                purchaseItemId = null;
            }

            return await _purchaseRepository.GetListAsync(filter, purchaseItemId);
        }

        public async Task<List<PurchaseItemLookupDto>> GetPurchaseItemLookupAsync()
        {
            var items = await _purchaseItemRepository.GetListAsync();
            return await items.ToPurchaseItemLookupDto();
        }

        private async Task<string> GenerateBarcode()
        {
            var random = new Random();
            string barcodeNumber;
            bool Exists = false;

            do
            {
                var randomNumber = random.Next(100000000, 999999999);
                barcodeNumber = randomNumber.ToString();

                var any = await _purchaseRepository.GetAsync(barcodeNumber);
                if(any == null)
                {
                    Exists = true;
                }

            } while (!Exists);
            
            var barcode = new Barcode
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = 300,
                Height = 100
            };

            var barcodeImage = barcode.Encode(TYPE.CODE128, barcodeNumber);
            var directoryPath = @"D:\barcode";
            var filePath = $@"{directoryPath}\barcode_{barcodeNumber}.png";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            barcodeImage.Save(filePath, ImageFormat.Png);

            return barcodeNumber;
        }
    }
}
