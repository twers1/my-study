import java.util.Scanner;
public class Main
{
    // 5.Дан список (сначала количество элементов, потом сами элементы). Потом водятся два числа: a и b. 
    // Поменяйте местами значения a-ого и b-ого элементов массива и выведите его на экран построчно. Гарантируется, что а и b не выходят за границы размеров массива.
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
	System.out.println("Введите количество элементов:");
    int num = sc.nextInt();
    int arr[] = new int[num];
    System.out.println("Введите элементы:");
	for (int i = 0; i < arr.length; i++) {
	    arr[i] = sc.nextInt();
	}
	System.out.println("Введите числа a и b: "); 
	int a = sc.nextInt();
    int b = sc.nextInt();
		    
    int temp = arr[a];
	arr[a] = arr[b];
	arr[b] = temp;
		         
	for (int i = 0; i < arr.length; i++) {
		System.out.println(arr[i]);
	}
    

}  
}


