using FTWWebserver.Domain;
using FTWWebserver.Application.StoreFile.Boundaries;

namespace FTWWebserver.Application.Commons.Extensions
{
    public static class ToFileExtension
    {
        public static File ToFile(this StoreFileInput input)
        {
            return new File(filename: input.Name,
                creationDate: input.UploadedDate,
                content: input.Bytes,
                producerName: "webcamRaspberry");
        }
    }
}