﻿namespace Smartbills.NET.Entities.Barcode
{
    public enum SBBarcodeType
    {

        AZTEC = 1,
        CODABAR = 2,
        CODE_39 = 4,
        CODE_93 = 8,
        CODE_128 = 16,
        DATA_MATRIX = 32,
        EAN_8 = 64,
        EAN_13 = 128,
        ITF = 256,
        MAXICODE = 512,
        PDF_417 = 1024,
        QR_CODE = 2048,
        RSS_14 = 4096,
        RSS_EXPANDED = 8192,
        UPC_A = 16384,
        UPC_E = 32768,
        All_1D = 61918,
        UPC_EAN_EXTENSION = 65536,
        MSI = 131072,
        PLESSEY = 262144,
        IMB = 524288,
        PHARMA_CODE = 1048576,
    }

}
