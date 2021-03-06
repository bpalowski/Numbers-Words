using System;
using System.Collections.Generic;
namespace Number
{
  public class NumberConverter
  {
  public string _userNumber;
  public NumberConverter(string userNumber)
  {
    _userNumber = userNumber;
  }

  Dictionary<string, string> ListOne = new Dictionary<string, string>(){{"1"," one"},{"2"," two"},{"3","three"},{"4"," four"},{"5","five"},{"6","six"},{"7"," seven"},{"8"," eight"},{"9"," nine"},{"10"," ten"},{"11"," eleven"},{"12"," twelve"},{"13"," thirteen"},{"14"," fourteen"},{"15"," fifteen"},{"16"," sixteen"},{"17"," seventeen"},{"18"," eighteen"},{"19"," nineteen"},{"20"," twenty"},{"30"," thirty"},{"40"," fourty"},{"50"," fifty"},{"60"," sixty"},{"70"," seventy"},{"80"," eighty"},{"90"," ninty"}};
  Dictionary<string, string> ListTwo = new Dictionary<string, string>(){{"1"," onehundred"},{"2"," twohundred"},{"3"," threehundred"},{"4"," fourhundred"},{"5"," fivehundred"},{"6"," sixhundred"},{"7"," sevenhundred"},{"8"," eighthundred"},{"9"," ninehundred"}};

    public string test()
    {
//////100
      string wordNumber = "";
      string numberReduce = _userNumber;
      if (_userNumber.Length >= 3)
      {
        numberReduce = _userNumber[_userNumber.Length - 2].ToString() + _userNumber[_userNumber.Length - 1].ToString();
      }
      int firstNumber = int.Parse(_userNumber);
      int testNumber = int.Parse(numberReduce);

      if (firstNumber < 20)
      {
      wordNumber = ListOne[_userNumber];
     }
     else if (testNumber < 10)
     {
       wordNumber = ListOne[_userNumber];
     }
     else if (testNumber < 20)
     {
       wordNumber = ListOne[_userNumber[_userNumber.Length - 2].ToString() + _userNumber[_userNumber.Length - 1].ToString()];
     }
      else if (_userNumber.Length >= 2 && _userNumber[_userNumber.Length -1].ToString() == "0")
     {
       wordNumber = ListOne[_userNumber];
     }
     else if (_userNumber.Length >= 2 && _userNumber[_userNumber.Length -1].ToString() != "0")
     {
     wordNumber = ListOne[_userNumber[_userNumber.Length -2].ToString() + "0"] + ListOne[_userNumber[_userNumber.Length -1].ToString()];
     }

     if (_userNumber.Length >= 3)
     {
     wordNumber = ListTwo[_userNumber[_userNumber.Length -3].ToString()] + wordNumber;
     }

      return wordNumber;

     }

  }
  public class OutputNumber
  {
    static void Main()
    {
      Console.WriteLine("Enter Number");
      string test1 = Console.ReadLine();
      NumberConverter number1 = new NumberConverter(test1);
      Console.WriteLine(number1.test());
    }
  }



}
