# Challenge 6a - Making global redundant

## Pre-Requisites
You should have completed challenge 5a before attempting this challenge.

## Background
Distributing geographically for latency reduction, performance increase and even compute fail-over provides significant value. But in a true disaster scenario these alone are not enough. To recover gracefully and be resilient in a total regional failure, you need the data for the service(s)/system(s) affected to be available to the fail-over services and systems on backup infrastructure.

## Challenge
Your challenge is to take your solution from challenge 5a, and make it globally reliable by implementing full high-availability and disaster-recovery fault tolerance. In the event of a regional failure (one of your two regions is unavailable), data for your instances will need to be available in the alternate region, and should be ‘reasonably’ up to date with the latest live version of the world. When your ‘replacement’ Minecraft servers come online, they should connect to the local data for that instance, and continue to serve the world

## Success Criteria
Given the complexity and variety of pottential solutions, the goals for this challenge are verified by our team of expert coaches. - Your data from each region should be replicated into the other region as a seconday ‘backup’. - In the event of a regional outage (region 1 offline entirely) the second region should recover per challenge 5a, but using the data replica in the same region.