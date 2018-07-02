# Challenge 6b - What scales up, must scale down

## Pre-Requisites

You should have completed challenge 5b before attempting this challenge.

### Background

Automating scale up/out operations gives the confidence that your system will meet even the largest of demand. Meeting that demand comes at a cost, but what about when the load is not sustained? A peak event, or sudden spike in activity, may double or triple your infrastructure cost in the cloud. Cost efficiencies are one of the greatest benefits of moving to the cloud. Having your deployments contract elastically when demand has passed not only means that you’re meeting demand, but truly only paying for what you need and what you use.

Of course it’s quite possible to monitor (You have been keeping that monitoring up to date haven’t you?) your usage and scale back your provisioned infrastructure manually. But where’s the fun in that?

### Challenge

Your challenge is to take the auto-scaling solution you configured in 5b, and using the thresholds you defined previously, configure this cluster to scale down automatically as usage reduces based on your scale metrics. Once correctly configured, your usage should always be within your acceptable threshold for scale-up/scale-down.

Your monitoring and telemetry solutions should clearly show the exceeded scale thresholds that have been crossed, and continue to track progress against them/back down towards them. When your telemetry lowers below a given threshold an informational alert/event should be raised informing you of the scale down event.

Be careful with the thresholds you choose, when auto-scale up and down are both configured if they are too close together, or too near the mean, your cluster will constantly fire scale events which may cause unexpected results.

### Success Criteria

 - Given the complexity and variety of potential solutions, the goals for this challenge are verified by our team of expert coaches.
   
-  When usage in cluster decreases below a defined threshold, excess Minecraft servers are de-provisioned.
   
- When resource consumption in cluster decreases below a defined threshold, resources are removed.
   
- Telemetry and monitoring solution should track usage and resource consumption relative to thresholds that have been exceeded.
   
- Telemetry and monitoring solution should log an informational event when usage/consumption lowers below a previously exceeded threshold.
