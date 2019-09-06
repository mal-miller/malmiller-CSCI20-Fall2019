using System;

class MainClass {
  public static void Main() 
  {
    
    Console.WriteLine("How many cents are you depositing?");
   
    string TotalMoneyString;
   
    int Q;
    int QM;
    int D;
    int DM;
    int N;
    int NM;
    int P;
    double FinalMoney;
    int Money;

    TotalMoneyString = Console.ReadLine();
    Money = int.Parse(TotalMoneyString);

    
    Q = Money/25;
    QM = Money%25;
    D = QM/10;
    DM = QM%10;
    N = DM/5;
    NM = DM%5;
    P = NM/1;
   
    Console.WriteLine (" You deposited " +Q+ " quarter(s), " +D+ " dime(s), " +N+ " nickle(s), and " +P+ " Penny(s)");

    Console.WriteLine ("But for our services we charge a fee of 10.9%");

    FinalMoney = (Money*0.01) - ((Money*0.01)*0.109);
    FinalMoney = Math.Round(FinalMoney, 2);

    Console.WriteLine ("After my fee, you get a voucher for $" +FinalMoney+ " Thank you, have a nice day.");  }
}