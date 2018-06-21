# Challenge 5b - Better living through auto-scale

## Background
Elasticity in the cloud is often a key goal for anyone looking to grow a service over time. The ability to scale dynamically to meet demand as it occurs brings confidence that you’re ready for anything, especially at those critical spikes in consumption that are often the make or break events. Cluster orchestrators only do so much for you however, and some solutions have limitations that you’ll uncover as scale increases.

## Challenge
Your challenge is to take the cluster you’ve been using up until this point, and configure demand based auto-scale. Whenever usage in your cluster reaches a specified threshold of your choosing, Minecraft servers should be spun up. When resource consumption in your cluster reaches a specified threshold - again, of your choosing, then more resources should be added to accommodate future capacity needs.

Your monitoring and telemetry solutions should clearly show the thresholds for scale, and track progress towards them. When a threshold is reached, an alert should fire notifying you of the scale event and the outcome.

## Success Criteria
Given the complexity and variety of potential solutions, the goals for this challenge are verified by our team of expert coaches.

- When usage increases in the cluster towards a defined threshold, additional Minecraft servers are provisioned.
- When resource consumption in the cluster reaches a defined threshold,additional resources are added.
- Telemetry and monitoring solution should track usage and resource consumption towards defined thresholds.
- Telemetry and monitoring solution should log an alert when thresholds are reached providing details of the event and outcome.