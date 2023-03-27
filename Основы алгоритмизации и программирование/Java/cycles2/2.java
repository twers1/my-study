import java.util.Scanner;
public class Main
{
    //  2.Вводится 2 целых числа a и b (a <= b). 
    // Необходимо вычислить сумму всех чисел от а до b включительно.
	public static void main(String[] args) {
            
         Scanner sc = new Scanner(System.in);
        int a =sc.nextInt();
        int b=sc.nextInt();
        int sum = 0;
        while(a<=b){
            
            
            sum+=a;
            a++;
       }
        System.out.println(sum);
        }
}     


