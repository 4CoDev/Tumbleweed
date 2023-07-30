// ReSharper disable once CheckNamespace

using Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Subroutine.Procedure.Nullary.Of;

public sealed class Scalar : Nullary.Any
{
	public Scalar(Any<Nullary.Any> action) =>
		this.action = action;
	
	public void Invoke() =>
		action.Value.Invoke();
	
	private readonly Any<Nullary.Any> action;
}