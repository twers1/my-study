import java.util.Scanner;
public class Main
{
   // 3. Напишите программу, действием которой будет занесение в переменную х1 числа 5, х2 числа 7,
   //  выяснением какое число больше и занесением его (большего) в x3.
	public static void main(String[] args) {
        int x1 = 5;
        int x2 = 7;
        int x3 =0;
        if(x1>x2) {
            x3 = x1;
            System.out.println("Большее число: " + x3);
        }
        else {
            x3 = x2;
            System.out.println("Большее число: " + x3);
        }

}  
}


