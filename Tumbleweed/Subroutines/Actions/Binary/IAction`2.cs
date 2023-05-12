namespace Tumbleweed.Subroutines.Actions.Binary;

public interface IAction<in T1, in T2>
{
	void InvokeWith(T1 first, T2 second);
}