Console.Clear();
Console.Write("введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());
switch (quarter)
{
  case 1:
    {
      Console.WriteLine("x>0 и y>0");
      break;
    }
  case 2:
    {
      Console.WriteLine("x<0 и y>0");
      break;
    }
  case 3:
    {
      Console.WriteLine("x<0 и y<0");
      break;
    }
  case 4:
    {
      Console.WriteLine("x>0 и y<0");
      break;
    }
  default:
    {
      Console.WriteLine("введена не правильная четверть!!!");
      break;
    }
}