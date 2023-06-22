/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;

bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string digits in ipv4Input)
{
  address = digits.Split(".", StringSplitOptions.RemoveEmptyEntries);

  ValidateLength();
  ValidateZeroes();
  ValidateRange();

  if (validLength && validZeroes && validRange) 
  {
      Console.WriteLine($"{digits} is a valid IPv4 address");
  } 
  else 
  {
      Console.WriteLine($"{digits} is an invalid IPv4 address");
  }
}

void ValidateLength()
{
  validLength = address.Length == 4;
}

void ValidateZeroes()
{
  for(int i = 0; i < (address.Count() - 1); i++)
  {
    if (address[i].Length > 1 && address[i].StartsWith("0"))
    {
      validZeroes = false;
    }
    else
    {
      validZeroes = true;
    }
  }
}

void ValidateRange()
{
  for(int i = 0; i < address.Count(); i++)
  {
    int digits = Convert.ToInt32(address[i]);
    
    if (digits < 0 || digits > 255)
    {
      validRange = false;
      break;
    }
    else
    {
      validRange = true;
    }
  }
}