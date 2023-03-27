import java.util.Scanner;
public class Main
{
    //  3.Напишем программу, которая считывает целые числа с клавиатуры 
    // и находит их сумму, если они заканчиваются на 7. Если ввели число,
    //  кратное 7, то программа должна завершиться (оно не суммируется).
	public static void main(String[] args) {
            
         Scanner sc = new Scanner(System.in);
        for (int n, res = 0; true; ) {
            if ((n = sc.nextInt()) % 7 == 0) {
                System.out.println(res);
                break;
            } else if (n % 10 != 7) continue;
            else res += n;
        }
        }
}     


