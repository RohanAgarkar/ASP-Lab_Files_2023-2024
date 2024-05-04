using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace controller_FileResult.controllers{
    public class FileController : Controller
    {
        [Route("/")]
        public string Index()
        {
            return "welcome to core application";
        }

        [Route("file1/download")]
        public VirtualFileResult FileDownload()
        {
            return new  VirtualFileResult("Desires-Batch B-group5.pdf", "application/pdf");
        }

        [Route("file2/download")]
        public PhysicalFileResult FileDonwload__()
        {
            return new PhysicalFileResult("C:\\Users\\blood\\Documents\\Game list.txt", "text/plain");
        }

        [Route("file3/download")]
        public FileContentResult FileDownload_()
        {
            return new FileContentResult(System.IO.File.ReadAllBytes("C:\\Users\\blood\\Documents\\University\\sem4\\asp.net\\FileController\\wwwRoot\\done.jpg"), "image/jpg");
        }
    }
}