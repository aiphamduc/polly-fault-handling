# What are Transient faults?

Transient faults relate to fault occurrences that exist for short periods of time, examples are:

- A network connection is unavailable while a router reboots
- Microservice starting up
- Server refusing connections due to connection pool exhaustion

## Why do we care?

If handled correctly:

- Rather than getting an error response & accepting failure
- We could _eventually_ get a success response

This is particularly advantageous in distributed (i.e. microservices) application architectures.

## Handling Transient Faults

We’ll focus on variations of the _Retry Policy_:

- Trying the request again, (and again?), to see if it succeeds _this time_...

We can configure:

- Number of retries (we probably don’t want to try forever)
- Time Interval between retires (constant or varying)

## What is Polly?

- The "De-facto" resilience & transient fault handling library for .NET
- We can use it to create Policies in our .NET apps
- This source is really an on-ramp to get you started.
- There are many more polices other than Retry that you can use:
  - Circuit Breaker
  - Timeout
  - Bulkhead Isolation
- More Info: https://github.com/App-vNext/Polly

# Reference:

Les Jackson
