class Program{

    static void Main(string[] args){


        
        inputChecker();
        
    }




        static public string input() {

        Console.WriteLine ("Please Input | Info for Information | Owner for list of Owner | Employee for Employee | SellingData for SellingData | EmployeeSell for EmployeeEarning |");
    
        return Console.ReadLine();
        }
         static public string input2() {

        Console.WriteLine ("Front of The House Type A Delivery Type B");
    
        return Console.ReadLine();
        }


        static void employeeChecker(){

            string X = input2();

            if (X == "A"){

                KFC_Information3 kfcinfo = new KFC_Information3();
                kfcinfo.Employee1 = "Mr Chaidee Rukdee Age20 Salary 15,000";
                kfcinfo.Employee2 = "Mr Norndee Jaidee Age 18 salary 15,000";
                kfcinfo.Employee3 = "Mr Apaidee Raendee Age 22 Salary 15,000";
                PrintEmployeeInformation1(kfcinfo);
            }
            else if(X == "B" ){
                
                KFC_Information3 kfcinfo = new KFC_Information3();
                kfcinfo.Employee4 = "Mr Tuamdee Ngandee Age 25 Salary 12,500";
                kfcinfo.Employee5 = "Mr Norndee Raebdee Age 23 Salary 12500";

                PrintEmployeeInformation2(kfcinfo);


            }
        }

       
        
        
        
        
        static void inputChecker() {

        string W = input();

        
        
        
        
        
        if (W == "Info"){

        KFC_Information kfcinfo = new KFC_Information();
        kfcinfo.Registered_Value = "1,000,000";
        kfcinfo.Branch_name = "KMUTT BANGKHUN TEIN";
        kfcinfo.address = "BANGKHUN TEIN Rd. Soi 27";
        
        PrintkfcInformation(kfcinfo);   

        }
        else if (W == "Owner"){

            KFC_Information2 kfcinfo = new KFC_Information2();
            kfcinfo.registered_Owner1 = "Mr. Tawee Jaidee ID 1536984561237";
            kfcinfo.registered_Owner2 = "Mr. Yuthadee TungJaiRaen ID 7421125687412";
            kfcinfo.registered_Owner3 = "Mr. James RukRongRaen ID 5417723215689";
            PrintOwnerInformation(kfcinfo);

        }
        else if(W== "SellingData"){
            Selling kfcinfo = new Selling();
            kfcinfo.ShopTotal = "17,526 Baht";
            kfcinfo.DeliveryTota = "218,628 baht";
            kfcinfo.ALL = "236,154 baht";
            PrintSelling(kfcinfo);
        }
        else if(W == "EmployeeSell")
        {
            int a = 236154 - 213069;
            Seller kfcIinfo = new Seller();
            kfcIinfo.Chaidee =   "Total Spending = 25,123.3 baht";
            kfcIinfo.Norndee =   "Total Spending = 25,209.025 baht";
            kfcIinfo.Apaidee =   "Total Spending = 25,246.525 baht";
            kfcIinfo.Tuamdee =   "Total Spending = 68,427.5 baht";
            kfcIinfo.Norndee2 =  "Total Spending = 69,063.2 baht";
            kfcIinfo.TotalCost = "Total = 213,069.55 baht";
            kfcIinfo.Profit =    "Profit = " + a.ToString() ;
            PrintSeller(kfcIinfo);

        }
        else if (W == "Employee"){

            employeeChecker();



        }

        


        
        else {
            Console.WriteLine("Please Input Info Owner or Employee");
        }
 
    }
        


    public static void PrintkfcInformation(KFC_Information kfc){
        Console.WriteLine("******************************");
        Console.WriteLine("---------- Information ----------");
        Console.WriteLine("{0}", kfc.Registered_Value);
        Console.WriteLine("{0}", kfc.Branch_name);
        Console.WriteLine("{0}", kfc.address);
        
        
        Console.WriteLine("******************************");

    }
    public static void PrintOwnerInformation(KFC_Information2 kfc){
        Console.WriteLine("---------- Owner ----------");
        Console.WriteLine("{0}", kfc.registered_Owner1);
        Console.WriteLine("{0}", kfc.registered_Owner2);
        Console.WriteLine("{0}", kfc.registered_Owner3);
    }

    public static void PrintEmployeeInformation1(KFC_Information3 kfc){
        Console.WriteLine("---------- EmployeeFrontoftheHouse ----------");
        Console.WriteLine("Position front of the House  |{0}", kfc.Employee1);
        Console.WriteLine("Position front of the House  |{0}", kfc.Employee2);
        Console.WriteLine("Position front of the House  |{0}", kfc.Employee3);
        
    }
    public static void PrintEmployeeInformation2(KFC_Information3 kfc){
        Console.WriteLine("---------- EmployeeDelivery ----------");
        Console.WriteLine("Position delivery            |{0}", kfc.Employee4);
        Console.WriteLine("Position delivery            |{0}", kfc.Employee5);
    }

    public static void PrintSelling(Selling kfc){

        Console.WriteLine("---------- Selling ----------");
        Console.WriteLine("Shop Sells = {0}", kfc.ShopTotal);
        Console.WriteLine("Delivery Sells = {0}", kfc.DeliveryTota);
        Console.WriteLine("Total = {0}", kfc.ALL);
    }
    public static void PrintSeller(Seller kfc){
        Console.WriteLine("---------- Selling ----------");
        Console.WriteLine("Chaidee  {0}", kfc.Chaidee);
        Console.WriteLine("Norndee  {0}", kfc.Norndee);
        Console.WriteLine("Apaidee  {0}", kfc.Apaidee);
        Console.WriteLine("Tuamdee  {0}", kfc.Tuamdee);
        Console.WriteLine("Norndee2 {0}", kfc.Norndee2);
        Console.WriteLine("{0}", kfc.TotalCost);
        Console.WriteLine("{0}", kfc.Profit);

    }





}



public class KFC_Information{

    public string Registered_Value;
    
    public string Branch_name;
    
    public string address;
    
    
} 

public class KFC_Information2{
    
    public string registered_Owner1;
    public string registered_Owner2;
    public string registered_Owner3;


}
public class KFC_Information3{
    
    public string Employee1;
    public string Employee2;
    public string Employee3;  
    public string Employee4;
    public string Employee5;


} 
public class Selling{

    public string ShopTotal;
    public string DeliveryTota;
    public string ALL;

}
public class Seller{

    public string Chaidee;
    public string Norndee;
    public string Apaidee;
    public string Tuamdee;
    public string Norndee2;
    public string TotalCost;
    public string Profit;
}


