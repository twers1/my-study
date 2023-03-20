import java.util.Scanner;
public class Main
{
    // 1.Пользователь вводит натуральное число. Необходимо вывести все
    // полные кубы натуральных чисел, не превосходящие этого числа.
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt();
        int i = 1;
        
        while(Math.pow(i, 3) <= n) {
            System.out.println(Math.pow(i, 3));
            i++;
            
        }
    }
}
