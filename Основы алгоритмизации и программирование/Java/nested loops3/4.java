import java.util.Scanner;
public class Main
{
    // 4.Напишите программу, которая выводит на экран все простые двузначные числа, квадрат которых не превышает 999.
        public static void main(String[] args) {
            for (int i = 2; i < 100; i++) {
            boolean a = true;
            int q = (int) Math.sqrt(i);
            for (int j = 2; j <= q; j++) {
                if ((i % j) == 0) {
                    a = false;
                    break;
                }
                if(Math.pow(i,2)<= 999) {
                    a = false;
                    break;
                }
            }
            if (a) {
                System.out.println(i + " простое");
            }
            
        }
        }

}  


