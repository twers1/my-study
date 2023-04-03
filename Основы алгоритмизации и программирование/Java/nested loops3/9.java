import java.util.Scanner;
public class Main
{
    // 9.Дано натуральное число n (n≤ 9). Напишите программу, которая печатает таблицу размером n×3 состоящую из данного числа
	public static void main(String[] args) {
        System.out.println("Введите число, которое меньше(или больше) числа 9: ");
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for(int i = 0; i<=n; i++) {
            for(int j = 1; j<=3; j++){
                System.out.println(i);
            }
            System.out.println(" ");
        }

}  
}


