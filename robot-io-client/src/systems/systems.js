// const SocketClient = require('./socketClient');
// const DataParser = require('./dataParser');
import SocketClient from './socketClient';
import DataStore from './dataStore';
import DataInputTest from './dataInputTest';

// module.exports = createRobotIOClient
import DataEntityManager from './dataEntityManager';
export default createSystems


function createSystems() {
    const dataStore = DataStore()
    const socketClient = SocketClient()
    const dataEntityManager = DataEntityManager()
    dataStore.onData.addListener(dataEntityManager.addData)
    dataStore.onReset.addListener(dataEntityManager.resetData)
    socketClient.onData.addListener(dataStore.addData)
    socketClient.onData.addListener(dataEntityManager.addData)
    const dataInputTest = DataInputTest()
    dataInputTest.onData.addListener(dataStore.addData)
    dataInputTest.onData.addListener(dataEntityManager.addData)
    dataInputTest.onReset.addListener(dataStore.deleteData)

    const systems = {
        dataEntityManager,
        dataInputTest,
        socketClient,
        dataStore
    }
    window.systems = systems

    return systems
}