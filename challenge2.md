# Challenge 2 - Let’s get ready to cluster!

## Background
Containers are extremely useful on their own, but their flexibility and potential is multiplied when deployed to an orchestrator/cluster.

You can learn more about the value of orchestrators at [docs.microsoft.com](https://docs.microsoft.com/), or more specifically the following links:

- [Service Fabric and Containers](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-containers-overview)
- [Introduction to Azure Container Service (AKS)](https://docs.microsoft.com/en-us/azure/aks/intro-kubernetes)

Once you have a cluster configured, you can react quickly to demand and leverage the extended functionality of the underlying platform to best suit your needs whether that’s:

- Deploying quickly and reliably.
- Scaling on at will to meet demand.
- Rolling out new features or upgrades.
- Utilizing only what resources you need for your current provision.

## Challenge
Your team’s goal in this challenge is to deploy the same container you used in challenge 1, to a cluster in Azure either with Service Fabric or Azure Container Service (AKS) in the EastUS Azure region.

## Success Criteria
- Create a cluster in Azure, running v1.0 of your chosen container, in the EastUS Azure region.

## References
- You can find the Minecraft containers on [Docker Hub](https://hub.docker.com/r/openhack/minecraft-server/)
- HINT: There is a second port on a Minecraft server for RCON (Remote Console) 25575, in addition to the default connection port (25565). The hack portal uses this to verify your server!!

Some other useful resources in addition to the ones in challenge 1 are:

- [Azure resource naming best practices](https://docs.microsoft.com/en-us/azure/architecture/best-practices/naming-conventions)
- [Azure CLI reference](https://docs.microsoft.com/en-us/cli/azure/get-started-with-azure-cli)
- [Kubectl overview](https://kubernetes.io/docs/user-guide/kubectl-overview/)
- [Service Fabric Containers Overview](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-containers-overview)