using System;

class Program
{
  static void Main()
  {
    Console.WriteLine(GetNumWords("Hello, World!"));
  }
  
  static int GetNumWords(string sStr)
  {
    int iNumWords = 0;
    bool isSpaceAvailable = true;
    int iIndex;
    while(isSpaceAvailable)
    {
      iIndex = sStr.IndexOf(" ");
      isSpaceAvailable = (iIndex == -1)? false: true;
      if(isSpaceAvailable)
      {
        iNumWords++;
        sStr = sStr.Substring(iIndex + 2);
      }
    }
    return iNumWords;
  }
}
