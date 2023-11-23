using Boolean = Tumbleweed.Mathematics.Boolean;
using System = System;

namespace Tumbleweed.Mathematics.Boolean;

public abstract class Envelope : Boolean::Any
{
	protected Envelope(Boolean::Any boolean) =>
		this.boolean = boolean;

	public System::Boolean State =>
		boolean.State;

	private readonly Boolean::Any boolean;
}