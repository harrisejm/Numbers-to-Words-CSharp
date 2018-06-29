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

  Dictionary<string, string> ListOne = new Dictionary<string, string>(){{"0",""},{"1"," one"},{"2"," two"},{"3","three"},{"4"," four"},{"5","five"},{"6","six"},{"7"," seven"},{"8"," eight"},{"9"," nine"},{"10"," ten"},{"11"," eleven"},{"12"," twelve"},{"13"," thirteen"},{"14"," fourteen"},{"15"," fifteen"},{"16"," sixteen"},{"17"," seventeen"},{"18"," eighteen"},{"19"," nineteen"},{"20"," twenty"},{"30"," thirty"},{"40"," forty"},{"50"," fifty"},{"60"," sixty"},{"70"," seventy"},{"80"," eighty"},{"90"," ninety"}};

  Dictionary<string, string> ListTwo = new Dictionary<string, string>(){{"0",""},{"1"," one hundred"},{"2"," two hundred"},{"3"," three-hundred"},{"4"," four-hundred"},{"5"," five-hundred"},{"6"," six-hundred"},{"7"," seven-hundred"},{"8"," eigh-thundred"},{"9"," nine-hundred"}};
  //onethousand
  Dictionary<string, string> ListThree = new Dictionary<string, string>(){{"0",""},{"1", " one-thousand"},{"2", " two-thousand"},{"3"," three-thousand"},{"4"," four-thousand"},{"5"," five-thousand"},{"6"," six-thousand"},{"7"," seven-thousand"},{"8"," eight-thousand"},{"9"," nine-thousand"}};
  //tenthousand
  Dictionary<string, string> ListFour = new Dictionary<string, string>() {{"0",""},{"1"," ten"},{"2"," twenty"},{"3"," thirty"},{"4"," forty"},{"5"," fifty"},{"6"," sixty"},{"7"," seventy"},{"8"," eighty"},{"9"," ninety"}};
  //hundred thousand
  // Dictionary<string, string> ListFive = new Dictionary<string, string>() {{"0",""},{"1"," one-hundred"},{"2"," two-hundred"},{"3"," three-hundred"},{"4"," four-hundred"},{"5"," five-hundred"},{"6"," six-hundred"},{"7"," seven-hundred"},{"8"," eight-hundred"},{"9"," nine-hundred"}};
  //million
  Dictionary<string, string> ListSix = new Dictionary<string, string>() {{"0",""},{"1"," one-million"},{"2"," two-million"},{"3"," three-million"},{"4"," four-million"},{"5"," five-million"},{"6"," six-million"},{"7"," seven-million"},{"8"," eight-milliion"},{"9"," nine-million"}};
 // ten million
  // Dictionary<string, string> ListSeven = new Dictionary<string, string>() {{"0",""},{"1"," ten"},{"2"," twenty"},{"3"," thirty"},{"4"," forty-million"},{"5"," fifty"},{"6"," sixty"},{"7"," seventy"},{"8"," eighty"},{"9"," ninty"}};
//hundred million
  // Dictionary<string, string> ListEight = new Dictionary<string, string>() {{"0",""},{"1"," one-hundred"},{"2"," two-hundred"},{"3"," three-hundred"},{"4"," four-hundred"},{"5"," five-hundred"},{"6"," six-hundred"},{"7"," seven-hundred"},{"8"," eight-hundred"},{"9"," nine-hundred"}};
  //one billion
    Dictionary<string, string> ListNine = new Dictionary<string, string>() {{"0",""},{"1"," one-billion"},{"2"," two-billion"},{"3"," three-billion"},{"4"," four-billion"},{"5"," five-billion"},{"6"," six-billion"},{"7"," seven-billion"},{"8"," eight-billion"},{"9"," nine-billion"}};
  //ten billion
    // Dictionary<string, string> ListTen = new Dictionary<string, string>() {{"0",""},{"1"," ten"},{"2"," twenty"},{"3"," thirty"},{"4","forty"},{"5"," fifty"},{"6"," sixty"},{"7"," seventy"},{"8"," eighty"},{"9"," ninty"}};
    //hundred billion
      // Dictionary<string, string> ListEleven = new Dictionary<string, string>() {{"0",""},{"1"," one-hundred"},{"2"," two-hundred"},{"3"," three-hundred"},{"4"," four-hundred"},{"5"," five-hundred"},{"6"," six-hundred"},{"7"," seven-hundred"},{"8"," eigh-thundred"},{"9"," nine-hundred"}};






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
     else if (_userNumber[_userNumber.Length - 2].ToString() == "0" && _userNumber[_userNumber.Length - 1].ToString() == "0")
     {
       wordNumber = "";
     }
     else if (_userNumber[_userNumber.Length - 2].ToString() == "0")
     {
       wordNumber = ListOne[_userNumber[_userNumber.Length - 1].ToString()];
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
       wordNumber = ListOne[_userNumber[_userNumber.Length - 2].ToString() + _userNumber[_userNumber.Length - 1].ToString()];
     }
    //  else if (_userNumber.Length >= 2 && _userNumber[_userNumber.Length - 2].ToString() == "0")
    // {
    //   wordNumber = "0" + ListOne[_userNumber[_userNumber.Length - 1].ToString()];
    // }
     else if (_userNumber.Length >= 2 && _userNumber[_userNumber.Length -1].ToString() != "0")
     {
     wordNumber = ListOne[_userNumber[_userNumber.Length -2].ToString() + "0"] + ListOne[_userNumber[_userNumber.Length -1].ToString()];
     }

//hundred
     if (_userNumber.Length >= 3)
     {
     wordNumber = ListTwo[_userNumber[_userNumber.Length -3].ToString()] + wordNumber;
     }
//one thousand
     if (_userNumber.Length >= 4)
     {
     wordNumber = ListThree[_userNumber[_userNumber.Length -4].ToString()] + wordNumber;
     }
  //tenthousand
     if (_userNumber.Length >= 5 && _userNumber[_userNumber.Length - 4].ToString() == "0" && _userNumber[_userNumber.Length - 5].ToString() != "0")
     {
     wordNumber = ListFour[_userNumber[_userNumber.Length -5].ToString()] + " thousand" + wordNumber;
     }
     else if (_userNumber.Length >= 5)
     {
     wordNumber = ListFour[_userNumber[_userNumber.Length -5].ToString()] + wordNumber;
     }
//  //hundred thousand
     if (_userNumber.Length >= 6 && _userNumber[_userNumber.Length - 4].ToString() == "0" && _userNumber[_userNumber.Length - 5].ToString() == "0")
     {
     wordNumber = ListTwo[_userNumber[_userNumber.Length -6].ToString()] + " thousand" + wordNumber;
     }
     if (_userNumber.Length >= 6)
     {
     wordNumber = ListTwo[_userNumber[_userNumber.Length -6].ToString()] + wordNumber;
     }
///million
     if (_userNumber.Length >= 7)
     {
     wordNumber = ListSix[_userNumber[_userNumber.Length -7].ToString()] + wordNumber;
     }
// ten million
     if (_userNumber.Length >= 8 && _userNumber[_userNumber.Length - 7].ToString() == "0" && _userNumber[_userNumber.Length - 8].ToString() != "0")
     {
     wordNumber = ListFour[_userNumber[_userNumber.Length -8].ToString()] + " million" + wordNumber;;
     }
     else if (_userNumber.Length >= 8)
     {
     wordNumber = ListFour[_userNumber[_userNumber.Length -8].ToString()] + wordNumber;
     }
  //hundred million
     if (_userNumber.Length >= 9 && _userNumber[_userNumber.Length - 8].ToString() == "0" && _userNumber[_userNumber.Length - 9].ToString() == "0")
     {
     wordNumber = ListTwo[_userNumber[_userNumber.Length -9].ToString()] + "million" + wordNumber;
     }
     else if (_userNumber.Length >= 9)
     {
     wordNumber = ListTwo[_userNumber[_userNumber.Length -9].ToString()] + wordNumber;
     }

//one billion
if (_userNumber.Length >= 10)
{
wordNumber = ListNine[_userNumber[_userNumber.Length -10].ToString()] + wordNumber;
}
//ten billion
if (_userNumber.Length >= 11 && _userNumber[_userNumber.Length - 10].ToString() == "0" && _userNumber[_userNumber.Length - 11].ToString() == "0")
{
wordNumber = ListFour[_userNumber[_userNumber.Length -11].ToString()] + "billion" + wordNumber;
}
else if (_userNumber.Length >= 11)
{
wordNumber = ListFour[_userNumber[_userNumber.Length -11].ToString()] + wordNumber;
}
//hundred billion
if (_userNumber.Length >= 12 && _userNumber[_userNumber.Length - 11].ToString() == "0" && _userNumber[_userNumber.Length - 12].ToString() == "0")
{
wordNumber = ListTwo[_userNumber[_userNumber.Length -12].ToString()] + "billion" + wordNumber;
}
else if (_userNumber.Length >= 12)
{
wordNumber = ListTwo[_userNumber[_userNumber.Length -12].ToString()] + wordNumber;
}
      return wordNumber;
     }
  }
  public class OutputNumber
  {
    static void Main()
    {
      Console.WriteLine("Enter Number 1 - 9,999,999,999");
      string test1 = Console.ReadLine();
      NumberConverter number1 = new NumberConverter(test1);
      Console.WriteLine(number1.test());
    }
  }
}
