namespace Tumbleweed.Event.Listening;

public interface Any<in T>
{
	void Unsubscribe();
	
	void Subscribe();
}