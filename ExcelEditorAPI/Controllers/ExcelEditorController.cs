using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExcelEditorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcelEditorController : ControllerBase
    {       

        [HttpGet]
        //async Task<ActionResult>
        public FileResult Get()
        {
            string pathSource = @"Workplace.xls";
            //string pathNew = @"c:\tests\newfile.txt";

            try
            {

                //using (FileStream fsSource = new FileStream(pathSource,
                //    FileMode.Open, FileAccess.Read))
                //{

                //    // Read the source file into a byte array.
                //    byte[] bytes = new byte[fsSource.Length];
                //    int numBytesToRead = (int)fsSource.Length;
                //    int numBytesRead = 0;
                //    while (numBytesToRead > 0)
                //    {
                //        // Read may return anything from 0 to numBytesToRead.
                //        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                //        // Break when the end of the file is reached.
                //        if (n == 0)
                //            break;

                //        numBytesRead += n;
                //        numBytesToRead -= n;
                //    }
                //    numBytesToRead = bytes.Length;


                //}

                byte[] file = System.IO.File.ReadAllBytes(pathSource);

                Stream stream = new MemoryStream(file);

                return File(stream, "application/octet-stream", $"test.xlsx");


            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }

            return null;
        }
    }
}
