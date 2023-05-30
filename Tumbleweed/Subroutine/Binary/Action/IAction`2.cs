namespace Tumbleweed.Subroutine.Binary.Action;

public interface IAction<in T1, in T2>
{
	void InvokeWith(T1 first, T2 second);
}