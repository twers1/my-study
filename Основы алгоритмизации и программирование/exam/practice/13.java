import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 13. Напишите программу, действием которой будет рисование таблицы n x 5 состоящую из числа n, введенного пользователем.

   
	public static void main(String[] args) {
        System.out.println("Введите число: ");
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for(int i = 0; i<=n; i++) {
            for(int j = 1; j<=5; j++){
                System.out.print(n);
            }
            System.out.println(" ");
        }

}  
}


