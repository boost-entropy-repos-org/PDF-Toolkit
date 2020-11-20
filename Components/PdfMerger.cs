using System.Collections.Generic;

namespace Components
{
    class PdfMerger
    {
        public static bool IsUploadComplete { get; set; } = false;
        public static bool IsMergeComplete { get; set; } = false;
        public static bool IsSubmitComplete { get; set; } = false;
        public static List<byte[]> Pdfs { get; set; } = new List<byte[]>();
        public static string SubmitMessage { get; set; } = string.Empty;
        public static string DownloadMessage { get; set; } = string.Empty;
        public static int TotalFiles { get; set; } = 0;
        public static int MaxFilesAllowed { get; } = 20;
        public static string Format { get; } = "data:application/pdf;base64,";
        public static string FinalMergedPdfURL { get; set; } = string.Empty;
    }
}