This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

## Available Scripts

In the project directory, you can run:

### `yarn start`

Runs the app in the development mode.<br />
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits.<br />
You will also see any lint errors in the console.

### `yarn test`

Launches the test runner in the interactive watch mode.<br />
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `yarn build`

Builds the app for production to the `build` folder.<br />
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.<br />
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

### `yarn eject`

**Note: this is a one-way operation. Once you `eject`, you can’t go back!**

If you aren’t satisfied with the build tool and configuration choices, you can `eject` at any time. This command will remove the single build dependency from your project.

Instead, it will copy all the configuration files and the transitive dependencies (webpack, Babel, ESLint, etc) right into your project so you have full control over them. All of the commands except `eject` will still work, but they will point to the copied scripts so you can tweak them. At this point you’re on your own.

You don’t have to ever use `eject`. The curated feature set is suitable for small and middle deployments, and you shouldn’t feel obligated to use this feature. However we understand that this tool wouldn’t be useful if you couldn’t customize it when you are ready for it.

## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

To learn React, check out the [React documentation](https://reactjs.org/).

## Installing SSL Certificate for Local Environment

1. In the root of the application, open up a command terminal, such as _Git Bash_ as an _Administrator_ user.
2. Run `npm install -g mkcert` to install _mkcert_ globally.
3. Run `mkcert localhost`
   * If you see a message that says the following:
    > The local CA is now installed in the system trust store! ⚡️<br />
    >The local CA is now installed in Java's trust store! ☕️
   * Run `mkcert -install`
4. The above commands should create both a _localhost.pem_ and  _localhost-key.pem_ files.
5. In your _.env.local_ file located in the root folder of the app, make sure these settings appear:
```
HTTPS=true 
SSL_CRT_FILE=localhost.pem 
SSL_KEY_FILE=localhost-key.pem
```

* Your React app should run as `https://localhost:3000` without displaying a _This site can’t provide a secure connection_ message in the browser.