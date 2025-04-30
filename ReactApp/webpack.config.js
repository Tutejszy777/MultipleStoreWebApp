const path = require('path');

module.exports = {
    entry: './src/index.jsx',
    output: {
        path: path.resolve(__dirname, '../MutipleStoreWebApp/wwwroot/react'),
        filename: 'bundle.js',
    },
    module: {
        rules: [
            {
                test: /\.(js|jsx)$/,
                exclude: /node_modules/,
                use: 'babel-loader',
            },
        ],
    },
    resolve: {
        extensions: ['.js', '.jsx'],
    },
    mode: 'development'
};