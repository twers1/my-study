import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   //7. Напишите программу, действием которой будет создание таблицы умножения до 10.
	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for (int i = 1; i<=9; i++){
            System.out.println(n + " * " + i + " = " +  n*i);
        }
            

}  
}


