* {
    box-sizing: border-box;
    margin: 0;
    padding: 0;
}

body {
    background-color: #05050a;
    color: #00ffcc;
    font-family: 'Orbitron', sans-serif;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    overflow: hidden;
}

canvas {
    background: radial-gradient(circle, #0b1329 0%, #020408 100%);
    border: 3px solid #00ffcc;
    box-shadow: 0 0 25px rgba(0, 255, 204, 0.4), inset 0 0 15px rgba(0, 255, 204, 0.2);
    border-radius: 6px;
    cursor: crosshair;
}

#ui {
    position: absolute;
    top: 20px;
    display: flex;
    gap: 20px;
    background: rgba(10, 15, 30, 0.85);
    padding: 10px 25px;
    border-radius: 30px;
    font-size: 16px;
    font-weight: 700;
    z-index: 10;
    border: 1px solid #00ffcc;
    box-shadow: 0 0 10px rgba(0, 255, 204, 0.3);
}

.stat-box {
    text-shadow: 0 0 5px #00ffcc;
}

#message-screen {
    position: absolute;
    background: rgba(5, 8, 20, 0.95);
    padding: 40px;
    border-radius: 12px;
    text-align: center;
    border: 2px solid #ff007f;
    box-shadow: 0 0 30px rgba(255, 0, 127, 0.5);
    z-index: 20;
    max-width: 450px;
}

#message-screen h1 {
    margin-bottom: 15px;
    color: #ff007f;
    font-size: 28px;
    text-shadow: 0 0 10px #ff007f;
}

#message-screen p {
    margin-bottom: 25px;
    line-height: 1.6;
    color: #a0aec0;
    font-size: 14px;
}

#start-btn {
    background: linear-gradient(45deg, #ff007f, #7928ca);
    color: white;
    border: none;
    padding: 14px 30px;
    font-size: 15px;
    font-family: 'Orbitron', sans-serif;
    font-weight: bold;
    border-radius: 4px;
    cursor: pointer;
    box-shadow: 0 0 15px rgba(255, 0, 127, 0.6);
    transition: all 0.2s ease;
}

#start-btn:hover {
    transform: scale(1.05);
    box-shadow: 0 0 25px rgba(255, 0, 127, 0.9);
}
