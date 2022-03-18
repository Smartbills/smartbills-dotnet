using System.ComponentModel.DataAnnotations;

namespace Smartbills.Client.Entities
{
    public enum SBBarcodeType
    {

        [Display(Name = "AZTEC")]
        AZTEC = 1,
        [Display(Name = "CODABAR")]
        CODABAR = 2,
        [Display(Name = "CODE_39")]
        CODE_39 = 4,
        [Display(Name = "CODE_93")]
        CODE_93 = 8,
        [Display(Name = "CODE_128")]
        CODE_128 = 16,
        [Display(Name = "DATA_MATRIX")]
        DATA_MATRIX = 32,
        [Display(Name = "EAN_8")]
        EAN_8 = 64,
        [Display(Name = "EAN_13")]
        EAN_13 = 128,
        [Display(Name = "ITF")]
        ITF = 256,
        [Display(Name = "MAXICODE")]
        MAXICODE = 512,
        [Display(Name = "PDF_417")]
        PDF_417 = 1024,
        [Display(Name = "QR_CODE")]
        QR_CODE = 2048,
        [Display(Name = "RSS_14")]
        RSS_14 = 4096,
        [Display(Name = "RSS_EXPANDED")]
        RSS_EXPANDED = 8192,
        [Display(Name = "UPC_A")]
        UPC_A = 16384,
        [Display(Name = "UPC_E")]
        UPC_E = 32768,
        [Display(Name = "All_1D")]
        All_1D = 61918,
        [Display(Name = "UPC_EAN_EXTENSION")]
        UPC_EAN_EXTENSION = 65536,
        [Display(Name = "MSI")]
        MSI = 131072,
        [Display(Name = "PLESSEY")]
        PLESSEY = 262144,
        [Display(Name = "IMB")]
        IMB = 524288,
        [Display(Name = "PHARMA_CODE")]
        PHARMA_CODE = 1048576,
    }

}
