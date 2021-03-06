```puml
@startuml
title Rotator State Machine
!include skin.puml
[*] --> Ready

state Ready <<Safe>>
Ready : OnEnter {azimuth motor = stopped; direction = none}
Ready --> Rotating : RotationDetected
Ready --> Rotating : __RotateToAzimuth__\nactions.RotateToAzimuth

state Rotating
Rotating: OnEnter {start rotation watchdog}
Rotating: OnEnter {azimuth motor = active; atHome = false;}
Rotating: OnExit {cancel rotation watchdog}
Rotating: OnExit {azimuth motor = stopped; direction = stopped}
Rotating --> Rotating : __RotationDetected__\nReset rotation watchdog
Rotating --> Ready : __RotatorStatusReceived__\nmachine.UpdateStatus
Rotating --> RequestStatus : WatchdogTimeout

state RequestStatus <<warning>>
RequestStatus: OnEnter {actions.RequestRotatorStatus}
RequestStatus --> RequestStatus : __RotationDetected__\nactions.EmergencyStop\nactions.RequestRotatorStatus
RequestStatus --> Ready : __RotatorStatusReceived__\nmachine.UpdateStatus

@enduml
```