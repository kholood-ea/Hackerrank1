using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//char c = 'g';
//int charzerobasedindex = Convert.ToInt32(c) - Convert.ToInt32('a');
//Console.WriteLine(charzerobasedindex);

namespace Problems
{
  public  class RecArea
    {
        static int getCharIndex(char letter)
        {
            var realIndex = Convert.ToInt32(letter - 'a');
            return realIndex;

        }

        static int getGivenIndex(int[] h, int num)
        {
            int givenIndex = 0;
            for (int j = 0; j <= h.Length; j++)
            {
                givenIndex = h[num];

            }

            return givenIndex;
        }

        public static int designerPdfViewer(int[] h, string word)
        {
            int RecArea = 0;
            int realIndex;
            int givenIndex = 0;
            for (int i = 0; i < word.Length; i++)
            {
                getCharIndex(word[i]);
                int max = getGivenIndex(h, getCharIndex(word[i]));

                for (int k = 0; k < word.Length - 1; k++)

                {
                    if (max < getGivenIndex(h, getCharIndex(word[k])))
                    {
                        max = getGivenIndex(h, getCharIndex(word[k]));
                    }

                }
                RecArea = max * word.Length;

            }

            return RecArea;

        }

     //       public static int designerPdfViewer(int[] h, string word)
     //   {
     //       int RecArea = 0 ;
     //       int realIndex;
     //       int givenIndex = 0;
     //       int getCharIndex(char letter)
     //       {
     //           realIndex = Convert.ToInt32(letter - 'a');
     //           return realIndex;

     //       }
     //       int getGivenIndex(int num) {

     //       for (int j = 0; j <= h.Length; j++)
     //       {
     //           givenIndex = h[num];
              
     //       }
                
     //           return givenIndex;
     //       }


     //       for (int i = 0; i < word.Length; i++)
     //       {
     //            getCharIndex(word[i]);
     //          int max = getGivenIndex(getCharIndex(word[i]));
               
     //           for (int k = 0; k < word.Length - 1; k++)

     //           {
     //               if (max < getGivenIndex(getCharIndex(word[k ])))
     //               {
     //                   max = getGivenIndex(getCharIndex(word[k]));
     ////Console.WriteLine($"givenindex { getGivenIndex(getCharIndex(word[i]))} recArea {RecArea}");
     //               }
                    
     //           }
     //         RecArea = max * word.Length;

     //       }

     //       return RecArea;


     //   }

       public static void readVariables()
        {

            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
            Console.ReadLine();

          
        }
    }
}
