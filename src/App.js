import React from 'react';
import './App.css';
import { LinkedinOutlined, GooglePlusOutlined, GithubOutlined } from '@ant-design/icons';

function App() {
  return (
    <div className="App">
      <div id='mainPart' className='hidden'>
        <!-- header -->
        <header className="App-header">
          <h1>Cornelius Frylinck's Portfolio</h1>
        </header>
        <div className="main">
        <div className='app-canvas'>
        <canvas id="ctx" style={{ top: 0, left: 0, width: '100%', height: '100%', position:'relative', border: 2 + "px  solid red" }}></canvas></div>
        </div>
        <!-- footer -->
        <footer style={{ width: '100vw', left: 0 }}>
          <div><a href="https://www.linkedin.com/in/cornelius-frylinck-710698188"><LinkedinOutlined /> Cornelius Frylinck</a></div>
          <div><GooglePlusOutlined /> cfrylinck1997@gmail.com</div>
          <div><a href=" https://github.com/Cornelius27584046/"><GithubOutlined /> Cornelius27584046</a></div>
          <div style={{float: 'left', bottom: 0, padding: 5 + 'px'}}>&copy; Cornelius Frylinck - 2020</div>
        </footer>
      </div>
      <div id="spinnerContainer" className="shown">
        <div id="spinner"></div>
      </div>
    </div>
  );
}

export default App;
