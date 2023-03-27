import java.util.Scanner;
public class Main
{
    // 5.По данному целому числу a и натуральному n вычислите сумму 
    // 1+a+a2+...+an, не используя формулу суммы геометрической прогрессии. Время работы программы должно быть пропорционально n. 
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        int n = sc.nextInt();
        int p = 1;
        for (int i = 1 ; i <= n ; ++i) {
            p+=(Math.pow(a,i));
        }
        System.out.print(p);
}     


