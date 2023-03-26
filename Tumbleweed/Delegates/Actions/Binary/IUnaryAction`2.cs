namespace Tumbleweed.Delegates.Actions.Binary;

public interface IBinaryAction<in T1, in T2>
{
	void Invoke(T1 parameter1, T2 parameter2);
}