import { applyMiddleware, createStore } from 'redux'
import { createBrowserHistory } from 'history'
import { routerMiddleware } from 'connected-react-router'
import thunk from 'redux-thunk'
import rootReducer from './rootReducer'

const rootStore = initialState => {
  const history = createBrowserHistory()
  const middlewares = [thunk]
  const store = createStore(rootReducer(), initialState, applyMiddleware(...middlewares))

  return store
}

export default rootStore
