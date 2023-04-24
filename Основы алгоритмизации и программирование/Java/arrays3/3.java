import java.util.Scanner;
public class Main
{
    // 3.Вводится натуральное число n. На следующей строчке вводятся n целых чисел. Считайте их как массив на n элементов. 
    // Затем вводится число k. Найдите индекс элемента k. Если такого элемента нет в массиве, выведите на экран слово Error
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
	System.out.println("Введите количество элементов: ");
    int n = sc.nextInt();
    
    
    int[] arr = new int[n];
    System.out.println("Введите элементы:");
	for(int i = 0; i < arr.length; i++){
            arr[i] = sc.nextInt();
    }
    
    System.out.println("Введите любой индекс элемента: ");
    int k = sc.nextInt();
    for(int i = 0; i < arr.length; i++){
            if(k == arr[i]){
                System.out.println(i); 
            }
            else {
                System.out.println("Error");
            }
        }
        
   
	
	
	
    

}  
}


