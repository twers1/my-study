import java.util.Scanner;
public class Main
{
    // 2.Вводится число n, затем n чисел целых, по одному на каждой строке. 
    // Затем вводится число, на которое нужно умножить все введённые выше числа. Выведите на экран результат умножения построчно.
	public static void main(String[] args) {
       Scanner sc = new Scanner(System.in);
       int n = sc.nextInt();
       int[] arr = new int[n];
       for(int i =0; i<n;i++){
        arr[i] = sc.nextInt();
       }
       int a = sc.nextInt();
       for(int i : arr){ 
        System.out.println(i*a);
       }

}  
}


