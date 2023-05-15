import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 19.  Вводится натурально число n. Напишите программу, которая выводит на экран построчно все числа от 1 до n.

   
	public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for(int i =1; i<=n; i++){
            System.out.println(i);
        }

}  
}


