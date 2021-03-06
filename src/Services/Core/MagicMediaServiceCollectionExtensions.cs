using MagicMedia.Face;
using MagicMedia.Metadata;
using MagicMedia.Processing;
using MagicMedia.Thumbnail;
using Microsoft.Extensions.DependencyInjection;

namespace MagicMedia
{
    public static class MagicMediaServiceCollectionExtensions
    {
        public static IServiceCollection AddMagicMedia(this IServiceCollection services)
        {
            services.AddFaceDetection();
            services.AddThumbnailService();
            services.AddSingleton<IMetadataExtractor, MetadataExtractor>();
            services.AddSingleton<IBoxExtractorService, BoxExtractorService>();
            services.AddSingleton<IImageTransformService, ImageTransformService>();
            services.AddSingleton<IWebPImageConverter, DefaultWebPImageConverter>();
            services.AddSingleton<IDateTakenParser, DateTakenParser>();
            services.AddSingleton<ICameraService, CameraService>();
            services.AddSingleton<IPersonService, PersonService>();
            services.AddSingleton<IFaceService, FaceService>();

            services.AddSingleton<IMediaProcesserTask, AutoOrientTask>();
            services.AddSingleton<IMediaProcesserTask, ExtractMetadataTask>();
            services.AddSingleton<IMediaProcesserTask, GenerateThumbnailsTask>();
            services.AddSingleton<IMediaProcesserTask, BuildFaceDataTask>();
            services.AddSingleton<IMediaProcesserTask, GenerateWebImageTask>();
            services.AddSingleton<IMediaProcesserTask, SaveMediaTask>();
            services.AddSingleton<IMediaProcesserTask, PredictPersonsTask>();

            services.AddSingleton<IMediaProcesserTaskFactory, MediaProcesserTaskFactory>();
            services.AddSingleton<IMediaProcessorFlowFactory, MediaProcessorFlowFactory>();
            services.AddSingleton<IMediaProcessorFlowFactory, MediaProcessorFlowFactory>();

            return services;
        }
    }
}
