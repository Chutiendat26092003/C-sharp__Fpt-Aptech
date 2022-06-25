using System;
using System.Text;

class ATM
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        User user1 = new User("1", "1", 2000000000);
        User user2 = new User("001203043509", "123456789", 20000);


        Console.WriteLine("---Mời bạn đăng nhập---");
        Console.Write("Nhập tài khoản:"); string username = Console.ReadLine();
        Console.Write("Nhập mật khẩu: "); string passwork = Console.ReadLine();
        int login = Login(username, passwork, user1);
        if (login == 1)
        {
            Console.WriteLine("Đăng nhập thành công!");
            int lc;
            do
            {
                Menu();
                lc = Convert.ToInt32(Console.ReadLine());
                switch (lc)
                {
                    case 1:
                        Console.WriteLine("Nhập số tiền bạn muốn rút:"); int rut = Convert.ToInt32(Console.ReadLine());
                        Withdraw(rut, user1);
                        break;
                    case 2:
                        Console.WriteLine("Nhập tài khoản bạn muốn chuyển:"); string tkChuyen = Console.ReadLine();
                        if (tkChuyen == user2.Username)
                        {
                            Console.WriteLine("Nhập số tiền bạn muốn chuyển:"); int chuyen = Convert.ToInt32(Console.ReadLine());
                            Transfer(chuyen, user1, user2);
                        } else
                        {
                            Console.WriteLine("Tài khoản không hợp lệ!");
                        }

                        break;
                    case 3:
                        Check(user1);
                        Check(user2);
                        break;
                }

            } while (lc != 0);
        }
        else
        {
            Console.WriteLine("Đăng nhập thất bại!");
        }

    }

    class User
    {
        string username;
        string password;
        int balance;

        public User(string username, string password, int balance)
        {
            Username = username;
            Password = password;
            Balance = balance;
        }

        public string Username
        {
            get { return username; }
            private set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public override string ToString()
        {
            return $"Username:{Username} \t Balance:{Balance}";
        }
    }

    static void Menu()
    {
        Console.WriteLine("\n----MENU----");
        Console.WriteLine("0. Thoát");
        Console.WriteLine("1. Rút tiền");
        Console.WriteLine("2. Chuyển tiền");
        Console.WriteLine("3. Kiểm tra số dư");
        Console.WriteLine("Mời bạn nhập lựa chọn!");
    }

    static int Login(string username, string password, User u)
    {
        if (username == u.Username && password == u.Password)
        {
            return 1;
        } else
        {
            return 0;
        }
    }

    static void Withdraw(int num, User u) 
    {
        if ((num%50 == 0) && (num <= 3000000) && (num <= u.Balance))
        {
            u.Balance -= num;
            Console.WriteLine("Giao dịch thành công!");
        }
        else
        {
            Console.WriteLine("Giao dịch thất bại!");
        }
    }

    static void Transfer(int num, User u1, User u2)
    {
        if ((num >= 0) && (num <= u1.Balance))
        {
            u1.Balance -= num;
            u2.Balance += num;
            Console.WriteLine("Giao dịch thành công!");
        }
        else
        {
            Console.WriteLine("Giao dịch thất bại!");
        }
    }

    static void Check(User u)
    {
        Console.WriteLine(u.ToString());
    }

}
