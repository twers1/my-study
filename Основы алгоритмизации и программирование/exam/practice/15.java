import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 15. Напишите программу, которая считывает 2 действительных числа и выводит их частное. 
   // Если это невозможно, то выводит слово "Error"

   
	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите 2 действительных числа: ");
        double a = sc.nextDouble();
        double b = sc.nextDouble();
        
        if(a/b != 0){
            System.out.println("Частное чисел: " + a/b);
        }
        else {
            System.out.println("Error");
        }
            

}  
}


