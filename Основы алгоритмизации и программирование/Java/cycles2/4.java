import java.util.Scanner;
public class Main
{
    //  4. Вводится натуральное число n. Вычислите n! ("эн-факториал") 
    // – произведение всех натуральных чисел от 1 до n  
	public static void main(String[] args) {
            
         Scanner sc = new Scanner(System.in);
       
        int a = sc.nextInt();
        int n = 1;
        for(int i = 1; i <= a;i++){
            n *= i;
        }System.out.println(n);
        }
}     


