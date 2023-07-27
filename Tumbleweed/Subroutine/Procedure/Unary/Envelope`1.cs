namespace Tumbleweed.Subroutine.Procedure.Unary;

public abstract class Envelope<T> : Unary.Any<T>
{
	protected Envelope(Unary.Any<T> action) =>
		this.action = action;
	
	public void InvokeWith(T parameter) =>
		action.InvokeWith(parameter);

	private readonly Unary.Any<T> action;
}