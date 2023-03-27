import java.util.Scanner;
public class Main
{
    // 10.Дано натуральное число. Найдите произведение его цифр.
	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int proizvedenie = 1;
        while(n != 0){
            proizvedenie *= (n % 10);
            n/=10;
        }
        System.out.println(proizvedenie);
}  
}


