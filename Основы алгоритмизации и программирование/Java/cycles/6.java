import java.util.Scanner;
public class Main
{
    // 6. Дано натуральное число N. Напишите программу, 
    // вычисляющую сумму цифр числа N.
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt(); // 12
        int sum = 0;
        
        while(n > 0) {
            sum+=n%10; 
            n/=10; 
        }
        System.out.println(sum);
            
        }        
}     


