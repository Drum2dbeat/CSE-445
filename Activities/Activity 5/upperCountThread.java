package activity_5;

/*
 * Name:	Oscar Jara
 * Date:	1/25/19
 * Class:	CSE 445
 */

public class upperCountThread extends Thread {

	int uppercount;
	String str;
	public upperCountThread(String str)
	{
		this.str = str;
	}
	
	public void run()
	{
		count();
	}
	
	public void count()
	{
		int len = str.length();
		for(int i = 0;i <len;i++)
			if(Character.isUpperCase(str.charAt(i)))
				uppercount++;	
	}
	
	public int getUpperCount()
	{
		return uppercount;
	}
	
}
