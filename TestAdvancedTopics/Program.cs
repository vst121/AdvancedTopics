using System;

namespace TestAdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckDelegateConcept();
            CheckLambdaConcept();
            CheckEventConcept();

            Console.ReadLine();
        }

        private static void CheckDelegateConcept()
        {
            Console.WriteLine("");
            Console.WriteLine("========");
            Console.WriteLine("Check Delegate Concept");
            Console.WriteLine("");
            Console.WriteLine("Without Delegates");
            PhotoProcessor p1 = new PhotoProcessor();
            p1.Process("photo.jpg");

            Console.WriteLine("--------");

            Console.WriteLine("With Delegate");
            DelegatePhotoProcessor p2 = new DelegatePhotoProcessor();
            var filters = new PhotoFilters();
            DelegatePhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.ApplyResize;
            filterHandler += ApplyCustomFilter;


            p2.Process("photo.jpg", filterHandler);

            Console.WriteLine("--------");

            Console.WriteLine("With Action");
            ActionPhotoProcessor p3 = new ActionPhotoProcessor();
            var myFilters = new PhotoFilters();
            Action<Photo> myFilterHandler = myFilters.ApplyBrightness;
            myFilterHandler += myFilters.ApplyContrast;
            myFilterHandler += myFilters.ApplyResize;
            myFilterHandler += ApplyCustomFilter;


            p3.Process("photo.jpg", myFilterHandler);  
        }

        static void ApplyCustomFilter(Photo photo)
        {
            Console.WriteLine("Applying Custom Filter ... ");
        }
        
        private static void CheckLambdaConcept()
        {
            Console.WriteLine("");
            Console.WriteLine("========");
            Console.WriteLine("Check Lambda Concept");
            Console.WriteLine("");

            var books = BookRepository.GetBooks();
            var cheapBooks = books.FindAll(book => book.Price < 300);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }


        private static void CheckEventConcept()
        {
            Console.WriteLine("");
            Console.WriteLine("========");
            Console.WriteLine("Check Event Concept");
            Console.WriteLine("");

            var video = new Video() { Title = "Video Title 1" };
            var videoEncoder = new VideoEncoder();
            var emailService = new EmailService();
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += emailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }

    }
}
