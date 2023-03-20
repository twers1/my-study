import java.util.Scanner;
public class Main
{
    // 2.Вводится 2 целых числа a и b (a <= b). Необходимо вычислить 
    // сумму всех чисел от а до b включительно.
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt();
        int b = sc.nextInt();
        int sum = 0;
        
        while(a<=b) { // 3 <= 5
        
            sum+=a; // 1. 0+=3(sum=3) 0+=4 0+=5
            a++; // 3++=4 4++=5
        }
        System.out.println(sum); // 12
    }
}
