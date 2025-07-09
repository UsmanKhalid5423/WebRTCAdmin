# Admin Panel - Answer Call System

This is a real-time call-handling admin panel built with ASP.NET Core Razor Pages, SignalR, and WebRTC. The system is designed for support/admin roles where **clients initiate calls**, and **any available admin can accept or reject**. Once a call is accepted by an admin, it becomes unavailable to others.

## 🔧 Features

- ✅ **Multiple Admins Support** – All active admins receive incoming client call notifications.
- 📞 **Call Handling** – Only one admin can answer a client's call.
- 🎥 **WebRTC Audio Support** – Real-time audio connection (no video) between client and admin.
- 🔄 **Active Users List** – Displays all connected clients in real-time.
- 🔔 **Incoming Call Popup** – Admins see an incoming call popup with accept/reject options.
- 📶 **ICE Candidate Handling** – Supports NAT traversal via Google STUN server.
- ⏱️ **Call Duration Timer** – Tracks and displays ongoing call duration.
- 🔕 **Ringing Audio** – Plays ringtone for incoming calls.

## 🧪 Technologies Used

- ASP.NET Core (Razor Pages)
- SignalR (Real-time WebSockets)
- WebRTC (Audio Streaming)
- Bootstrap 5 (UI Styling)
- JavaScript (Client Logic)

## 🏁 How It Works

1. **Client initiates a call** using `CallUser()` on the server.
2. **All connected admins receive** the call offer via `ReceiveOffer`.
3. One admin accepts → starts WebRTC connection using `AnswerCall`.
4. Others receive `CallAnswered` or `StopRinging` to hide the popup.
5. Call can be ended by either party via `EndCall`.
