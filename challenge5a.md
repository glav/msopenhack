# Challenge 5a - Going global

## Background
Larger scale applications often aren’t restricted to just one geographical location. It’s often the case that improvements in performance through reduction of latency are leveraged by larger services to offer customers the very best experience possible. Containers allow you to quickly deploy identical versions of a service to different geographies, perform rolling ‘follow the moon’ upgrades to minimize end-user downtime, and even to fail-over compute. As powerful and flexible as cluster technology now is, there’s a limit to how much is configured automatically, and that’s where you come in…

## Challenge
Your challenge is to replicate the cluster you created in challenge 2, by creating a second cluster across the Atlantic ocean in the WestEurope region. You’ll still only be able to use one endpoint for verification, but any traffic that hits your cluster should be routed to the nearest geographical cluster. You should also be able to monitor and manage both of your clusters using the tenant manager service and portal you created in challenge 4.

## Success Criteria
Given the complexity and variety of potential solutions, the goals for this challenge are verified by our team of expert coaches.

- One cluster present in EastUS region.
- One cluster present in WestEurope region.
- Traffic to endpoint is routed to nearest available cluster.
    - If a cluster is entirely unavailable (offline), traffic should be routed to the next available cluster.
- Monitoring, Telemetry and Tenant Management available for both clusters.

## References
- [Azure Traffic Manager Overview](https://docs.microsoft.com/en-us/azure/traffic-manager/traffic-manager-overview)
- [Azure Load Balancer Overview](https://docs.microsoft.com/en-us/azure/load-balancer/load-balancer-overview)