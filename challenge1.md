# Challenge 1 - Do you even Docker fam?

## Background
Docker containers are increasingly adopted as a great way to alleviate ‘Works on my machine’ type issues in development. They form the core of OpenHack and underpin everything you’ll be exploring as you progress through the challenges.

Challenge 1 sets out to ensure you understand the very basics of containers and can work with them locally and in a basic cloud scenario. In this challenge you’ll be taking an existing service/application that’s been containerized, running it locally and ensuring it works, then moving it to the cloud.

The existing application we’ll be using is Minecraft. To help, we’ve prepared two custom Docker images for hosting a Minecraft server, one Linux image based on the Alpine distribution, and one Windows images based on the Windows Server Nano image.

## Prerequisites
- [Docker for Windows](https://www.docker.com/docker-windows)
- [Windows Installation Guide](https://docs.docker.com/docker-for-windows/install/)

or

- [Docker for Mac](https://www.docker.com/docker-mac)
- [Mac Installation Guide](https://docs.docker.com/docker-for-mac/install/)

## Challenge
Your goal is to deploy one of the two different custom Minecraft Docker images we’ve prepared for you. First locally to Docker on your own machine, and then as a team to an Azure Container Instance.

The images are available here: https://hub.docker.com/r/openhack/minecraft-server/

To pass this challenge, you should ensure you are deploying version 1.0 of your chosen container.

## Success Criteria
- Everyone on your team must demonstrate your chosen v1.0 container running on their machine to a coach. Do this by connecting to Minecraft on localhost and show them the ‘Message of the Day’ in the Minecraft console from that image.
- As a team, submit a single endpoint for an Azure Container Instance running your chosen v1.0 container to the OpenHack portal. The hack portal will verify your Azure configuration and Minecraft server, and unlock challenge 2.

## References
- [docs.docker.com](https://docs.docker.com/get-started/) should have all the information you need on running your first container.
- Hint: The default port for Minecraft is 25565

Some other useful resources are:

- [Dockerfile reference](https://docs.docker.com/engine/reference/builder/)
- [Docker CLI reference](https://docs.docker.com/engine/reference/commandline/cli/)
- [Azure CLI reference](https://docs.microsoft.com/en-us/cli/azure/get-started-with-azure-cli)
- [Azure Container Instances Documentation](https://docs.microsoft.com/en-us/azure/container-instances/)
- [Windows Containers Documentation](https://docs.microsoft.com/en-us/virtualization/windowscontainers/index)