using System.Text.RegularExpressions;
using CourseEnquiry1API.Domain;

namespace CourseEnquiry1
{
    public sealed class Functions
    {
        private Functions()
        {
        }

        private static string RemoveSpecialChars(string text)
        {
            Regex regex = new Regex("[^a-zA-Z0-9 -]");
            return regex.Replace(text, "");
        }

        public static int GetPagerStartPage(int currentPage, int numberOfPagesToShow, int totalPages)
        {
            int startPage = 1;

            if (currentPage <= numberOfPagesToShow)
                startPage = 1;
            else if ((currentPage > numberOfPagesToShow) && (currentPage % numberOfPagesToShow == 0))
                startPage = ((currentPage / numberOfPagesToShow) - 1) * numberOfPagesToShow + 1;
            else if (currentPage > numberOfPagesToShow)
                startPage = (currentPage / numberOfPagesToShow) * numberOfPagesToShow + 1;

            return startPage;
        }

        public static int GetPagerEndPage(int startPage, int currentPage, int numberOfPagesToShow, int totalPages)
        {
            int endPage = startPage + (numberOfPagesToShow - 1);

            if (endPage >= totalPages)
                return totalPages;
            else
                return startPage + (numberOfPagesToShow - 1);
        }

        public static string GetWebApiBaseAddress()
        {
            return "http://localhost:27231/";
        }

        public static int GetGridNumberOfRows()
        {
            return 15;
        }

        public static int GetGridNumberOfPagesToShow()
        {
            return 10;
        }
    }
}
