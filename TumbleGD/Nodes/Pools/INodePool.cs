using Tumbleweed.Delegates.Actions;
using Tumbleweed.Delegates.Actions.Nullary;

namespace TumbleGD.Nodes.Pools;

public interface INodePool
{
	IDictionary<Object, INullaryAction> Graphicals { get; }
	
	IDictionary<Object, INullaryAction> Physicals { get; }
	
	IDictionary<Object, INullaryAction> Inputs { get; }
}